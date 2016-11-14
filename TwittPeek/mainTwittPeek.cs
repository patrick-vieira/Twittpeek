using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace TwittPeek
{
    public class mainTwittPeek
    {
        public struct Usuarios
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string ScreenName { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int FavouritesCount { get; set; }
            public int FriendsCount { get; set; }
            public int FollowersCount { get; set; }
            public string Language { get; set; }
            public string ProfileImageUrl { get; set; }
            public string ProfileImageUrlFullSize { get; set; }
            public int StatusesCount { get; set; }
            public bool Verified { get; set; }
            public string Url { get; set; }
            public DateTime CreatedAt { get; set; }

        }

        public struct Texto
        {
            public long Id { get; set; } //tweet
            public long CreatedById { get; set; } //user
            public string FullText { get; set; }
            public string[] Hashtags { get; set; }
            public string Language { get; set; }
            public int PublishedTweetLength { get; set; }
        }

        public struct Tweets2
        {

            public long Id { get; set; }
            public string IdStr { get; set; }
            public long CreatedById { get; set; } //user
            public long? InReplyToUserId { get; set; }
            public long? InReplyToStatusId { get; set; }
            public bool IsRetweet { get; set; }
            public DateTime CreatedAt { get; set; }
            public int FavoriteCount { get; set; }
            public bool Favorited { get; set; }
            public int PublishedTweetLength { get; set; }
            public long? QuotedStatusId { get; set; }
            public string Url { get; set; }
            public long?[] UserMentions { get; set; }
            public string Source { get; set; }
            

        }

        public struct Tweets
        {
            public int index { get; set; }
            public long ID { get; set; }
            public string CreatedAt { get; set; }
            public string Text { get; set; }
            public string FullText { get; set; }
            public string Source { get; set; }
            public string CreatedBy { get; set; }
            public int RetweetCount { get; set; }
            public bool Favorited { get; set; }
            public int FavoriteCount { get; set; }
            public bool Retweeted { get; set; }
            public string Language { get; set; }
            public int PublishedTweetLength { get; set; }
            public string TweetLocalCreationDate { get; set; }
            public bool IsRetweet { get; set; }
            public bool IsTweetPublished { get; set; }
            public bool IsTweetDestroyed { get; set; }
            public string Url { get; set; }

            public object[] all
            {
                get
                {
                    return new object[]
                    {
                        index,
                        ID,
                        CreatedAt,
                        Text,
                        FullText,
                        Source,
                        CreatedBy,
                        RetweetCount,
                        Favorited,
                        FavoriteCount,
                        Retweeted,
                        Language,
                        PublishedTweetLength,
                        TweetLocalCreationDate,
                        IsRetweet,
                        IsTweetPublished,
                        IsTweetDestroyed,
                        Url
                    };
                }
                set
                {
                    index = (int)value[17];
                    ID = (long)value[0];
                    CreatedAt = (string)value[1];
                    Text = (string)value[2];
                    FullText = (string)value[3];
                    Source = (string)value[4];
                    CreatedBy = (string)value[5];
                    RetweetCount = (int)value[6];
                    Favorited = (bool)value[7];
                    FavoriteCount = (int)value[8];
                    Retweeted = (bool)value[9];
                    Language = (string)value[10];
                    PublishedTweetLength = (int)value[11];
                    TweetLocalCreationDate = (string)value[12];
                    IsRetweet = (bool)value[13];
                    IsTweetPublished = (bool)value[14];
                    IsTweetDestroyed = (bool)value[15];
                    Url = (string)value[16];
                }
            }

            public object getField(string field_name)
            {
                object oReturn = null;

                switch (field_name)
                {
                    case "index":
                        return index;

                    case "ID":
                        return ID;

                    case "PublishedTweetLength":
                        return PublishedTweetLength;

                    case "RetweetCount":
                        return RetweetCount;

                    case "FavoriteCount":
                        return FavoriteCount;

                    default:
                        return oReturn;

                };

            }
        }
        
        public Tweets[] arrTweets;
        
        public mainTwittPeek()
        {
            
        }

        public void mCarregaDados(IList<Tweetinvi.Models.ITweet> tweets)
        {
            int index = 0;
            int iTemp = 0;
            bool bTemp;

            arrTweets = new Tweets[tweets.Count];

            foreach (Tweetinvi.Models.ITweet tweet in tweets)
            {
                arrTweets[index].ID = tweet.Id;

                arrTweets[index].CreatedAt = tweet.CreatedAt.ToString();

                arrTweets[index].Text = tweet.Text.ToString();

                arrTweets[index].FullText = tweet.FullText.ToString();

                arrTweets[index].Source = tweet.Source.ToString();

                arrTweets[index].CreatedBy = tweet.CreatedBy.ToString();

                Int32.TryParse(tweet.RetweetCount.ToString(), out iTemp);
                arrTweets[index].RetweetCount = iTemp;

                Boolean.TryParse(tweet.Favorited.ToString(), out bTemp);
                arrTweets[index].Favorited = bTemp;

                Int32.TryParse(tweet.FavoriteCount.ToString(), out iTemp);
                arrTweets[index].FavoriteCount = iTemp;

                Boolean.TryParse(tweet.Retweeted.ToString(), out bTemp);
                arrTweets[index].Retweeted = bTemp;

                arrTweets[index].Language = tweet.Language.ToString();

                Int32.TryParse(tweet.PublishedTweetLength.ToString(), out iTemp);
                arrTweets[index].PublishedTweetLength = iTemp;

                arrTweets[index].TweetLocalCreationDate = tweet.TweetLocalCreationDate.ToString();

                Boolean.TryParse(tweet.IsRetweet.ToString(), out bTemp);
                arrTweets[index].IsRetweet = bTemp;

                Boolean.TryParse(tweet.IsTweetPublished.ToString(), out bTemp);
                arrTweets[index].IsTweetPublished = bTemp;

                Boolean.TryParse(tweet.IsTweetDestroyed.ToString(), out bTemp);
                arrTweets[index].IsTweetDestroyed = bTemp;

                arrTweets[index].Url = tweet.Url.ToString();

                index++;
            }


        }

        public void mCarregaDados(int nQuantidade)
        {
            arrTweets = new Tweets[nQuantidade];

            string fileXML = Directory.GetParent(Directory.GetCurrentDirectory()) + "\\Dados\\" + "Search" + nQuantidade.ToString() + "Resultados" + ".xml";

            if (File.Exists(fileXML))
            {
                DataSet oDataSetDados = new DataSet();

                oDataSetDados.ReadXml(fileXML);

                DataTable oTable = oDataSetDados.Tables["Search" + nQuantidade.ToString() + "Resultados"];

                int index = 0;

                int iTemp;
                bool bTemp;
                long lTemp;

                for (index = 0; index < nQuantidade; index++)
                {
                    DataRow oRow = oTable.Rows[index];

                    //o id vai ser o que vem depois da ultima barra da URL

                    arrTweets[index].index = index;

                    Int64.TryParse(oRow["Url"].ToString().Split('/').Last(), out lTemp);
                    arrTweets[index].ID = lTemp;

                    arrTweets[index].CreatedAt = oRow["CreatedAt"].ToString();

                    arrTweets[index].Text = oRow["Text"].ToString();

                    arrTweets[index].FullText = oRow["FullText"].ToString();

                    arrTweets[index].Source = oRow["Source"].ToString();

                    arrTweets[index].CreatedBy = oRow["CreatedBy"].ToString();

                    Int32.TryParse(oRow["RetweetCount"].ToString(), out iTemp);
                    arrTweets[index].RetweetCount = iTemp;

                    Boolean.TryParse(oRow["Favorited"].ToString(), out bTemp);
                    arrTweets[index].Favorited = bTemp;

                    Int32.TryParse(oRow["FavoriteCount"].ToString(), out iTemp);
                    arrTweets[index].FavoriteCount = iTemp;

                    Boolean.TryParse(oRow["Retweeted"].ToString(), out bTemp);
                    arrTweets[index].Retweeted = bTemp;

                    arrTweets[index].Language = oRow["Language"].ToString();

                    Int32.TryParse(oRow["PublishedTweetLength"].ToString(), out iTemp);
                    arrTweets[index].PublishedTweetLength = iTemp;

                    arrTweets[index].TweetLocalCreationDate = oRow["TweetLocalCreationDate"].ToString();

                    Boolean.TryParse(oRow["IsRetweet"].ToString(), out bTemp);
                    arrTweets[index].IsRetweet = bTemp;

                    Boolean.TryParse(oRow["IsTweetPublished"].ToString(), out bTemp);
                    arrTweets[index].IsTweetPublished = bTemp;

                    Boolean.TryParse(oRow["IsTweetDestroyed"].ToString(), out bTemp);
                    arrTweets[index].IsTweetDestroyed = bTemp;

                    arrTweets[index].Url = oRow["Url"].ToString();
                }

            }


        }     


        public DataTable preencheGrid()
        {
            DataTable oTable = new DataTable("Tweets");

            oTable.Columns.Add("index", typeof(int));
            oTable.Columns.Add("ID", typeof(long));

            oTable.Columns.Add("CreatedAt", typeof(string));
            oTable.Columns.Add("Text", typeof(string));
            oTable.Columns.Add("FullText", typeof(string));
            oTable.Columns.Add("Source", typeof(string));
            oTable.Columns.Add("CreatedBy", typeof(string));

            oTable.Columns.Add("RetweetCount", typeof(int));
            oTable.Columns.Add("Favorited", typeof(bool));
            oTable.Columns.Add("FavoriteCount", typeof(int));
            oTable.Columns.Add("Retweeted", typeof(bool));

            oTable.Columns.Add("Language", typeof(string));

            oTable.Columns.Add("PublishedTweetLength", typeof(int));
            oTable.Columns.Add("TweetLocalCreationDate", typeof(string));
            oTable.Columns.Add("IsRetweet", typeof(bool));
            oTable.Columns.Add("IsTweetPublished", typeof(bool));
            oTable.Columns.Add("IsTweetDestroyed", typeof(bool));
            oTable.Columns.Add("Url", typeof(string));


            if (arrTweets == null)
                return oTable;
            //melhorar isso aqui tbm, da pra fazer em poucas linhas, assim ta muito feio

            oTable.Clear();

            foreach (Tweets oTweet in arrTweets)
            {
                oTable.Rows.Add(oTweet.all);
            }
            
            return oTable;
        }


    }
}