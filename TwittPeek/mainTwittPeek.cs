using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace TwittPeek
{
    public class mainTwittPeek
    {
        [Serializable]
        public struct Usuarios
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string ScreenName { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int FriendsCount { get; set; }
            public int FollowersCount { get; set; }
            public string Language { get; set; }
            public string ProfileImageUrl { get; set; }
            public int StatusesCount { get; set; }
            public bool Verified { get; set; }
            public string Url { get; set; }
            public DateTime CreatedAt { get; set; }

        }

        [Serializable]
        public struct Texto
        {
            public long Id { get; set; } //tweet
            public long CreatedById { get; set; } //user
            public string FullText { get; set; }
            public string[] Hashtags { get; set; }
            public string Language { get; set; }
            public int PublishedTweetLength { get; set; }
        }

        [Serializable]
        public struct TweetsEstruturado
        {
            public int chave { get; set; }
            public Texto oTexto { get; set; }
            public Usuarios oUsuario { get; set; }

            public long ID { get; set; }
            public string CreatedAt { get; set; }
            public string Source { get; set; }
            public int RetweetCount { get; set; }
            public bool Favorited { get; set; }
            public int FavoriteCount { get; set; }
            public bool Retweeted { get; set; }
            public bool IsRetweet { get; set; }
            public string Url { get; set; }

            public object[] all
            {
                get
                {
                    return new object[]
                    {
                        chave,
                        ID,
                        CreatedAt,
                        oUsuario.Name,
                        oTexto.FullText,
                        string.Join(",",oTexto.Hashtags),
                        oTexto.PublishedTweetLength,
                        oUsuario.Location,
                        oUsuario.FollowersCount,
                        oUsuario.FriendsCount,
                        oUsuario.Verified,
                        oUsuario.ProfileImageUrl,
                        Source,
                        RetweetCount,
                        Favorited,
                        FavoriteCount,
                        Retweeted,
                        oTexto.Language,
                        IsRetweet,
                        Url
                    };
                }

            }

            public object getField(string field_name)
            {
                object oReturn = null;

                switch (field_name)
                {
                    case "chave":
                        return chave;                        

                    case "PublishedTweetLength":
                        return oTexto.PublishedTweetLength;

                    case "RetweetCount":
                        return RetweetCount;

                    case "FavoriteCount":
                        return FavoriteCount;

                    case "FriendsCount":
                        return oUsuario.FriendsCount;

                    case "FollowersCount":
                        return oUsuario.FollowersCount;

                    case "StatusesCount":
                        return oUsuario.StatusesCount;

                    default:
                        return oReturn;

                };

            }
        }

        private Texto getTexto(Tweetinvi.Models.ITweet oTweet)
        {
            Texto oTexto = new Texto();
            oTexto.Id = oTweet.Id;
            oTexto.CreatedById = oTweet.CreatedBy.Id;  
            oTexto.FullText = oTweet.FullText;

            oTexto.Hashtags = new string[oTweet.Hashtags.Count];
            int hash_count = 0;
            foreach (Tweetinvi.Logic.TwitterEntities.HashtagEntity hashtag in oTweet.Hashtags)
            {
                oTexto.Hashtags[hash_count] = hashtag.Text;
                hash_count++;
            }
            oTexto.Language = oTweet.Language.ToString();
            oTexto.PublishedTweetLength = oTweet.PublishedTweetLength;

            return oTexto;
        }

        private Usuarios getUsuario(Tweetinvi.Models.ITweet oTweet)
        {
            Usuarios oUsuario = new Usuarios();

            oUsuario.Id = oTweet.CreatedBy.Id;
            oUsuario.Name = oTweet.CreatedBy.Name;
            oUsuario.ScreenName = oTweet.CreatedBy.ScreenName;
            oUsuario.Description = oTweet.CreatedBy.Description;
            oUsuario.Location = oTweet.CreatedBy.Location.ToString();
            oUsuario.FriendsCount = oTweet.CreatedBy.FriendsCount;
            oUsuario.FollowersCount = oTweet.CreatedBy.FollowersCount;
            oUsuario.Language = oTweet.CreatedBy.Language.ToString();
            oUsuario.ProfileImageUrl = oTweet.CreatedBy.ProfileImageUrl;
            oUsuario.StatusesCount = oTweet.CreatedBy.StatusesCount;
            oUsuario.Verified = oTweet.CreatedBy.Verified;
            oUsuario.Url = oTweet.CreatedBy.Url;
            oUsuario.CreatedAt = oTweet.CreatedBy.CreatedAt;
            
            return oUsuario;
        }

        void atualizaListaArquivos()
        {
            listaArquivos = new List<string>();

            char[] separador = { '.' };

            var arquivos = new DirectoryInfo(dadosPath).GetFiles("*.bin");
            foreach (var arquivo in arquivos)
            {
                listaArquivos.Add(arquivo.Name.Split(separador)[0]);
            }
        }

        public TweetsEstruturado[] arrTweetsEstruturado;
        public string ultimoAberto
        {
            get
            {
                string line;
                string temp = "";
                StreamReader file = new StreamReader(dadosPath + "\\" + "ultimo aberto.txt");
                while ((line = file.ReadLine()) != null)
                    temp = line;
                file.Close();

                return temp;
            }
            set
            {
                var serializer = new BinaryFormatter();
                using (StreamWriter sw = File.CreateText(dadosPath + "\\" + "ultimo aberto.txt"))
                    sw.WriteLine(value);
                
            }
        }
        public string dadosPath = Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + "\\Dados";
        public List<string> listaArquivos;

        public mainTwittPeek()
        {           
            atualizaListaArquivos();

        }        

        public void load_estruturado(string file)
        {
            var serializer = new BinaryFormatter();

            if (file != null && file != "")
                using (var stream = File.OpenRead(dadosPath + "\\" + file + ".bin"))
                    arrTweetsEstruturado = (TweetsEstruturado[])serializer.Deserialize(stream);
        }

        public void save_estruturado(string file)
        {
            var serializer = new BinaryFormatter();

            //grava o arquivo novo
            using (var stream = File.OpenWrite(dadosPath + "\\" + file + ".bin"))
                serializer.Serialize(stream, arrTweetsEstruturado);

            //update do ultimo aberto
            ultimoAberto = file;

            atualizaListaArquivos();
        }

        public void add_estruturado(string file)
        {
            //carrega o arquivo em um array o tamanho do novo array vai ser o carregado mais o atual, salva esse novo no mesmo arquivo de antes;

            using (var fileStream = new FileStream(file, FileMode.Append))
            {
                var bFormatter = new BinaryFormatter();
                bFormatter.Serialize(fileStream, arrTweetsEstruturado);
            }
        }

        public void mAppendDados_estruturado(IList<Tweetinvi.Models.ITweet> tweets)
        {
            int index = arrTweetsEstruturado.Length;
            Array.Resize<TweetsEstruturado>(ref arrTweetsEstruturado, tweets.Count + arrTweetsEstruturado.Length);


            foreach (Tweetinvi.Models.ITweet tweet in tweets)
            {
                arrTweetsEstruturado[index].chave = index;
                arrTweetsEstruturado[index].ID = tweet.Id;
                arrTweetsEstruturado[index].CreatedAt = tweet.CreatedAt.ToString();
                arrTweetsEstruturado[index].Source = tweet.Source;
                arrTweetsEstruturado[index].RetweetCount = tweet.RetweetCount;
                arrTweetsEstruturado[index].Favorited = tweet.Favorited;
                arrTweetsEstruturado[index].FavoriteCount = tweet.FavoriteCount;
                arrTweetsEstruturado[index].Retweeted = tweet.Retweeted;
                arrTweetsEstruturado[index].IsRetweet = tweet.IsRetweet;
                arrTweetsEstruturado[index].Url = tweet.Url;

                arrTweetsEstruturado[index].oTexto = getTexto(tweet);
                arrTweetsEstruturado[index].oUsuario = getUsuario(tweet);

                index++;
            }
        }

        public void mCarregaDados_estruturado(IList<Tweetinvi.Models.ITweet> tweets)
        {
            int index = 0;

            arrTweetsEstruturado = new TweetsEstruturado[tweets.Count];

            foreach (Tweetinvi.Models.ITweet tweet in tweets)
            {
                arrTweetsEstruturado[index].chave = index;
                arrTweetsEstruturado[index].ID = tweet.Id;
                arrTweetsEstruturado[index].CreatedAt = tweet.CreatedAt.ToString();
                arrTweetsEstruturado[index].Source = tweet.Source;
                arrTweetsEstruturado[index].RetweetCount = tweet.RetweetCount;
                arrTweetsEstruturado[index].Favorited = tweet.Favorited;
                arrTweetsEstruturado[index].FavoriteCount = tweet.FavoriteCount;
                arrTweetsEstruturado[index].Retweeted = tweet.Retweeted;
                arrTweetsEstruturado[index].IsRetweet = tweet.IsRetweet;
                arrTweetsEstruturado[index].Url = tweet.Url;

                arrTweetsEstruturado[index].oTexto = getTexto(tweet);
                arrTweetsEstruturado[index].oUsuario = getUsuario(tweet);

                index++;
            }
        }

        public DataTable preencheGrid_estruturado()
        {
            DataTable oTable = new DataTable("Tweets");
            
            oTable.Columns.Add("chave", typeof(int));
            oTable.Columns.Add("ID", typeof(long));
            oTable.Columns.Add("CreatedAt", typeof(string));
            oTable.Columns.Add("oUsuario.Name", typeof(string));
            oTable.Columns.Add("FullText", typeof(string));
            oTable.Columns.Add("oTexto.Hashtags", typeof(string));
            oTable.Columns.Add("oTexto.PublishedTweetLength", typeof(int));
            oTable.Columns.Add("oUsuario.Location", typeof(string));
            oTable.Columns.Add("oUsuario.FollowersCount", typeof(int));
            oTable.Columns.Add("oUsuario.FriendsCount", typeof(int));
            oTable.Columns.Add("oUsuario.Verified", typeof(bool));
            oTable.Columns.Add("oUsuario.ProfileImageUrl", typeof(string));
            oTable.Columns.Add("Source", typeof(string));
            oTable.Columns.Add("RetweetCount", typeof(int));
            oTable.Columns.Add("Favorited", typeof(bool));
            oTable.Columns.Add("FavoriteCount", typeof(int));
            oTable.Columns.Add("Retweeted", typeof(bool));
            oTable.Columns.Add("oTexto.Language", typeof(string));
            oTable.Columns.Add("IsRetweet", typeof(bool));
            oTable.Columns.Add("Url", typeof(string));
            

            if (arrTweetsEstruturado == null)
                return oTable;
            //melhorar isso aqui tbm, da pra fazer em poucas linhas, assim ta muito feio

            oTable.Clear();

            foreach (TweetsEstruturado oTweet in arrTweetsEstruturado)
            {
                oTable.Rows.Add(oTweet.all);
            }

            return oTable;
        }









        [Serializable]
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

        public void add(string file)
        {
            //carrega o arquivo em um array o tamanho do novo array vai ser o carregado mais o atual, salva esse novo no mesmo arquivo de antes;

            using (var fileStream = new FileStream(file, FileMode.Append))
            {
                var bFormatter = new BinaryFormatter();
                bFormatter.Serialize(fileStream, arrTweets);
            }
        }
        public void save(string file)
        {
            var serializer = new BinaryFormatter();

            //grava o arquivo novo
            using (var stream = File.OpenWrite(dadosPath + "\\" + file + ".bin"))
                serializer.Serialize(stream, arrTweets);

            //update do ultimo aberto
            using (StreamWriter sw = File.CreateText(dadosPath + "\\" + "ultimo aberto.txt"))
                sw.WriteLine(file);

            atualizaListaArquivos();
        }
        public void load(string file)
        {
            var serializer = new BinaryFormatter();

            if (file != null && file != "")
                using (var stream = File.OpenRead(dadosPath + "\\" + file + ".bin"))
                    arrTweets = (Tweets[])serializer.Deserialize(stream);
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