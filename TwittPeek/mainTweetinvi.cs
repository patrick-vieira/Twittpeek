﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Streams;
using Tweetinvi.Streaming;
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
            var matchingTweets = Search.SearchTweets(sSearch);

            return matchingTweets;
        }

        /// <summary>
        /// Faz uma com tamanho de entradas apartir de uma palavra
        /// </summary>
        /// <param name="sSearch"></param>
        /// <returns>Array com 100 os ultimos twetts contendo a palavra</returns>
        public List<ITweet> mSearchTweets(string sSearch, int size)
        {
            List<ITweet> matchingTweets = new List<ITweet>();

            var stream = Tweetinvi.Stream.CreateFilteredStream();

            // Filter by keywords and type of tweets using the AddTrack method
            //Filter by location using the AddLocation method
            //Filter by user using the AddFollow method

            stream.AddTrack(sSearch);
            //stream.AddTweetLanguageFilter(Language.Portuguese);
            
            //stream.AddLocation();


            stream.MatchingTweetReceived += (sender, args) =>
            {
                // Do what you want with the Tweet.
                //Console.WriteLine(args.Tweet);
                matchingTweets.Add(args.Tweet);
                if (matchingTweets.Count >= size)
                    stream.StopStream();
            };
            stream.StartStreamMatchingAllConditions();
            //stream.StartStreamMatchingAllConditionsAsync();
            stream.ResumeStream();

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

        /// <summary>
        /// Pesquisa mais detalhada baseada em parametros
        /// </summary>
        /// <returns>array de tweets</returns>
        public IList<ITweet> mSearchTweets(string sSearch, int maxNumberOfResults, DateTime Since, DateTime Until, double latitude, double longitude, double radius)
        {
            var searchParameter = new SearchTweetsParameters(sSearch)
            {
                //GeoCode = new GeoCode(latitude, longitude, radius, DistanceMeasure.Kilometers),
                //Lang = Language.Portuguese,
                SearchType = SearchResultType.Mixed,
                MaximumNumberOfResults = maxNumberOfResults,
                Since = Since,
                Until = Until,
                //MaxId = 405001488843284480,
                Filters = TweetSearchFilters.None
            };
            
            return Search.SearchTweets(searchParameter).ToArray();
        }


        public void mFilteredStream(string sWord)
        {
            var stream = Tweetinvi.Stream.CreateFilteredStream();
            stream.AddTrack(sWord);
            stream.MatchingTweetReceived += (sender, args) =>
            {
                Console.WriteLine("A tweet containing '" + sWord +"' has been found; the tweet is '" + args.Tweet + "'");
            };


            //location DF
            //var centerOfNewYork = new Location(new Coordinates(-15.517205, -48.218994), new Coordinates(-16.003576, -47.362061));
            //stream.AddLocation(centerOfNewYork);    

            stream.StartStreamMatchingAllConditions();
        }


        public void mStream(string sWord)
        {

            var stream = Tweetinvi.Stream.CreateSampleStream();
            stream.TweetReceived += (sender, args) =>
            {
                // Do what you want with the Tweet.
                Console.WriteLine(args.Tweet);

            };


            stream.StartStream();
        }

        void mTesteParametro(string sWord)
        {
            var fs = Tweetinvi.Stream.CreateFilteredStream();
            fs.AddTrack("@userScreenName");


            string b = fs.StreamState.ToString();
            //fs.StartStreamMatchingAllConditions();

            var stream = Tweetinvi.Stream.CreateSampleStream();
            stream.TweetReceived += (sender, args) =>
            {
                // Do what you want with the Tweet.
                Console.WriteLine(args.Tweet);

                if(args.Tweet.PublishedTweetLength < 13)
                    stream.StopStream();
            };
            stream.StartStream();

        }

        public void mReply()
        {
            var firstTweet = Tweet.PublishTweet("I love Tweetinvi!");

            var reply = Tweet.PublishTweet("Tweetinvi loves you back", new PublishTweetOptionalParameters
            {
                InReplyToTweet = firstTweet
            });

        }

        public void mPostImagem(string sPath)
        {
            

            byte[] file1 = File.ReadAllBytes(sPath);
            var media = Upload.UploadImage(file1);

            var tweet = Tweet.PublishTweet("This is my awesome photo!", new PublishTweetOptionalParameters
            {
                Medias = new List<IMedia> { media }
            });
        }

        public void mTweetinvi_testes()
        {
            // Simple Search
            //var matchingTweets = Search.SearchTweets("fatima");
            //mStream("dilma");

            //Thread workerThread = new Thread(DoWork);

            //workerThread.Start();

            //shouldStop = !_shouldStop;

            //mTesteParametro("PSOL");

            //var tweetDTO = TwitterAccessor.ExecutePOSTQuery<ITweetDTO>("https://api.twitter.com/1.1/statuses/update.json?status=hello");
            //var userDTO = TwitterAccessor.ExecuteGETQuery<ITweetDTO>("https://api.twitter.com/1.1/users/show.json?q=trump");
            //var jsonObject = TwitterAccessor.GetQueryableJsonObjectFromGETQuery("https://api.twitter.com/1.1/search/tweets.json?q=trump");
            //var fieldValue = jsonObject["field_name"];

            //var matchingTweets = Search.SearchTweets("trump");

            var searchParameter = new SearchTweetsParameters("obama")
            {
                //GeoCode = new GeoCode(-30.0090019, -51.1971623, 100000, DistanceMeasure.Kilometers),
                //GeoCode = new GeoCode(40.644444, -73.948333, 1, DistanceMeasure.Miles),
                
                Lang = Language.English,
                SearchType = SearchResultType.Mixed,
                MaximumNumberOfResults = 100,
                //Since = new DateTime(2013, 01, 11),
                //SinceId = 399616835892781056,
                //Until = new DateTime(2016, 11, 3),
                //MaxId = 405001488843284480,
                //Filters = TweetSearchFilters.None
            };

            var tweets = Search.SearchTweets(searchParameter);



        }
        
        private volatile bool _shouldStop = true;

        public void DoWork()
        {
            while (!_shouldStop)
            {
                Console.WriteLine("worker thread: working...");
            }
            Console.WriteLine("worker thread: terminating gracefully.");
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

    }
}
