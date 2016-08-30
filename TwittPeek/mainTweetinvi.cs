using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Models.DTO;
using Tweetinvi.Parameters;

namespace TwittPeek
{
    public class csTwitts
    {
        public IEnumerable<Tweetinvi.Models.ITweet> arrTwitts { get; set; }

        //todos esses elementos fazem parte do array já
        public Tweetinvi.Models.IUser user { get; set; }
        public DateTime createdAt { get; set; }
        public Tweetinvi.Models.Entities.ITweetEntities entities { get; set; }
        public string fullText { get; set; }
        public List<Tweetinvi.Models.Entities.IHashtagEntity> hashTags { get; set; }

        public string UrlTwitter { get; set; }
        public List<Tweetinvi.Models.Entities.IUrlEntity> Urls { get; set; }
        
    }

    public class csUsersFollowing
    {
        public IEnumerable<IUser> arrFollowing { get; set; }
    }


    public class csUsersFollowers
    {
        public IEnumerable<IUser> arrFollowers { get; set; }
    }

    public class csMainTweetinvi
    {
        csTwitts oTwitts;
        csUsersFollowing oUsersFollowing;
        csUsersFollowers oUsersFollowers;


        /// <summary>
        /// Autentica o usuario do TwettPeek, setando as chaves e token, para realizar a comunicação com o twitter
        /// </summary>
        public void startApplication()
        {
            string CONSUMER_KEY = "HeDQMRBdc69V32zIm39LiiAJq";
            string CONSUMER_SECRET = "ah6HY1LYtL3jEqKqacNqXr2dXcOiKAitzTORlUWawo8SYtHvfI";
            string ACCESS_TOKEN = "770279416182210560-CfAQpyrLBtEhYDebYCWO2clwFAmqkMQ";
            string ACCESS_TOKEN_SECRET = "Ha5pGDzaPtWbjkLTLgviq7GR4iZTBrm5bTLhyX4r5A7kq";

            // Applies credentials for the current thread. If used for the first time, set up the ApplicationCredentials
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);

            // When a new thread is created, the default credentials will be the Application Credentials
            Auth.ApplicationCredentials = new TwitterCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);

            var userTweetPeek = User.GetAuthenticatedUser();
            Debug.WriteLine(userTweetPeek.ScreenName);

            // Get and AccountSettings object from the authenticatedUser object
            var settings = userTweetPeek.GetAccountSettings();
            
        }

        /// <summary>
        /// Função para fazer um post
        /// </summary>
        /// <param name="text">texto de até 140 caracteres</param>
        /// <returns>uma boleana que diz se o tweet foi publicado</returns>
        public bool mPostTwitt(string text)
        {
            var oResult = Tweet.PublishTweet(text);

            return oResult.IsTweetPublished;
        }

        /// <summary>
        /// Lista arrays que apareceriam na timeline do usuario logado TwettPeek
        /// </summary>
        /// <param name="numTwittsToGet">Numero de twetts que sera retornado [1:200]</param>
        /// <returns>Array com até 200 twitts da timeline do TwettPeek</returns>
        public IEnumerable<Tweetinvi.Models.ITweet> mGetHomeTimeline(int numTwittsToGet)
        {
            oTwitts = new csTwitts();

            oTwitts.arrTwitts = Timeline.GetHomeTimeline(numTwittsToGet);

            return oTwitts.arrTwitts;
        }

        /// <summary>
        ///  Busca usuarios que esse usuario segue
        /// </summary>
        /// <param name="oUser"></param>
        /// <returns>Array de "todos os"(pode ser que seja limitado) usuarios que este usuario segue</returns>
        public IEnumerable<IUser> mGetFollowing(IUser oUser = null)
        {
            oUsersFollowing = new csUsersFollowing();

            oUser = oUser == null ? (oUser = User.GetAuthenticatedUser()) : oUser;

            oUsersFollowing.arrFollowing = User.GetFollowers(oUser);
            oUsersFollowing.arrFollowing = User.GetFriends(oUser);

            return oUsersFollowing.arrFollowing;
        }

        /// <summary>
        /// Busca seguidores do usuario usado no parametro de chamada
        /// </summary>
        /// <param name="oUser"></param>
        /// <returns>Array de todos os usuarios que seguem o usuario do parametro de entrada</returns>
        public IEnumerable<IUser> mGetFollowers(IUser oUser = null)
        {
            oUsersFollowers = new csUsersFollowers();

            oUser = oUser == null ? (oUser = User.GetAuthenticatedUser()) : oUser;

            oUsersFollowers.arrFollowers = User.GetFollowers(oUser);

            return oUsersFollowers.arrFollowers;
        }



        /// <summary>
        /// Faz uma pesquisa simples apartir de uma palavra
        /// </summary>
        /// <param name="sSearch"></param>
        /// <returns>Array com 100 os ultimos twetts contendo a palavra</returns>
        public IEnumerable<ITweet> mSearchTweets(string sSearch)
        {
            var matchingTweets = Search.SearchTweets("dilma");

            return matchingTweets;
        }

        /// <summary>
        /// Pesquisa mais detalhada baseada em parametros
        /// </summary>
        /// <returns>array de tweets</returns>
        public IEnumerable<ITweet> mSearchTweets()
        {

            var searchParameter = new SearchTweetsParameters("dilma")
            {


                //Decimal Values porto alegre
                //Latitude =  -30.031055
                //Longitude = -51.196289

                GeoCode = new GeoCode(-30.031055, -51.196289, 109, DistanceMeasure.Kilometers),
                Lang = Language.Portuguese,
                SearchType = SearchResultType.Popular,
                MaximumNumberOfResults = 500,
                Until = new DateTime(2016, 08, 29),
                SinceId = 399616835892781056,
                MaxId = 405001488843284480,
                Filters = TweetSearchFilters.None
            };

            var tweets = Search.SearchTweets(searchParameter);

            return tweets;

        }


        public void mFilteredStream(string sWord)
        {
            var stream = Stream.CreateFilteredStream();
            //stream.AddTrack(sWord);
            stream.MatchingTweetReceived += (sender, args) =>
            {
                Console.WriteLine("A tweet containing '" + sWord +"' has been found; the tweet is '" + args.Tweet + "'");
            };


            //location DF
            var centerOfNewYork = new Location(new Coordinates(-15.517205, -48.218994), new Coordinates(-16.003576, -47.362061));
            stream.AddLocation(centerOfNewYork);    

            stream.StartStreamMatchingAllConditions();
        }


        public void mStream(string sWord)
        {

            var stream = Stream.CreateSampleStream();
            stream.TweetReceived += (sender, args) =>
            {
                // Do what you want with the Tweet.
                Console.WriteLine(args.Tweet);
            };


            stream.StartStream();
        }

        public void mTweetinvi_testes()
        {
            //mFilteredStream("golpe");
            //mSearchTweets();
            mFilteredStream("fatima");
        }


    }
}
