using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{

    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message() { }

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }
    
        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return (_likes / elapsed)*100000;

        }

        public void Messages()
        {
            Console.WriteLine("Sisu:{0}\nAutor: {1}", Content, Author);
        }


        public string ShowPopularity(double esimene, double teine)
        {

            string  result = "";
            if (esimene > teine) { result = "Esimene sõune on polaarsem kui teine"; };
            if (esimene < teine) { result = "Teine sõune on polaarsem kui Esimene"; };
            return result;

        }

        public string ShowPopularityN(List<Message> messages)
        {

            string result = "";
            double popularity = 0;
            for (int i = 0; 1 < messages.Count; i++)
            {
                if (messages[i].GetPopularity()>popularity) 
                {
                    popularity = messages[i].GetPopularity();
                    result = messages[i].Content + " on kõige populaarse sõnum, seda kirjutas " + messages[i].Author;
                    
                }
            }
            return result;
                                            
        }

    }
}


    

