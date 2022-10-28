namespace Polymorphism_example
{
    internal class Program
    {
        public class News
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; } = DateTime.Now;
            public string GetHappyNews()
            {
                string happyNews = "Happy! " + Description;

                return happyNews;
            }

            public virtual string GetWelcomeNews()
            {
                string welcomeNews = "Welcome! " + Description;

                return welcomeNews;
            }

            public string GetTransactionNews()
            {
                string welcomeNews = "Transaction! " + Description;

                return welcomeNews;
            }
        }


        public class SuperNews : News
        {
            public string SuperMethod()
            {
                string superNews = "Super! " + Description;

                return superNews;
            }

            public override string GetWelcomeNews()
            {
                string welcomeNews = "OverrideWelcome! " + Description;

                return welcomeNews;
            }

            public new string GetTransactionNews()
            {
                string welcomeNews = "NewTransaction! " + Description;

                return welcomeNews;
            }

        }

        static void Main(string[] args)
        {

            News newsObject = new News();

            newsObject.Description = "First News";

            Console.WriteLine("Hello, World!");

            Console.WriteLine(newsObject.Description);

            Console.WriteLine(newsObject.GetHappyNews());


            SuperNews superNewsObject = new SuperNews();

            superNewsObject.Description = "First super news";


            Console.WriteLine(superNewsObject.Description);

            Console.WriteLine(superNewsObject.GetHappyNews());

            Console.WriteLine(superNewsObject.SuperMethod());

            Console.WriteLine("");

            Console.WriteLine(superNewsObject.GetWelcomeNews());

            Console.WriteLine(superNewsObject.GetTransactionNews());

            Console.WriteLine("");

            News tempNews = new SuperNews();

            Console.WriteLine(tempNews.GetWelcomeNews());

            Console.WriteLine(tempNews.GetTransactionNews());

        }
    }
}