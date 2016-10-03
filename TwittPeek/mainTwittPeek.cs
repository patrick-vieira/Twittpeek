using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwittPeek
{
    class mainTwittPeek
    {
        ///usar essa classe para ao ivez da frm para ficar mais organizado
        ///hoje os dados tem que passar pelo frm principal antes de chegar no usrviw que ordena
        ///
        public struct Tweets
        {
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
                get { return new object[] {
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
                    Url }; }
                set
                {
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

        }

    }
}
