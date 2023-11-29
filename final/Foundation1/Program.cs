using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> cList1 = new List<Comment>();
        List<Comment> cList2 = new List<Comment>();
        List<Comment> cList3 = new List<Comment>();
        List<Comment> cList4 = new List<Comment>();

        videos.AddRange(new List<Video>
        {
            new Video("Cool New Vid", "Vlogger42", 90, cList1),
            new Video("Check this out!", "TechTalk", 165, cList2),
            new Video("We Need to Talk about Apple", "MacAndMe", 800, cList3),
            new Video("How I Turned $3 into $3 Million in Stocks", "LuckyGambler", 423, cList4)
        });        

        cList1.AddRange(new List<Comment>
        {
            new Comment("Goon4343", "lol no u"),
            new Comment("BobbyTheKid", "That was really cool!"),
            new Comment("kanchiwawa", "Loved it! Keep up the great work!"),
            new Comment("JDKepler", "Eh, not impressed.")
        });

        cList2.AddRange(new List<Comment>
        {
            new Comment("CantaPerMe", "Love it"),
            new Comment("Revec22", "First!"),
            new Comment("ParkeShark", "I saw this on another site and thought it looked gimmicky."),
            new Comment("Devastating_Warrior", "Not for me")
        });

        cList3.AddRange(new List<Comment>
        {
            new Comment("jeppers", "I really want to get a Pro with M3"),
            new Comment("xx_flowery", "I prefer Android"),
            new Comment("Nekoinc", "If their stuff wasn't so expensive, I might consider switching over"),
            new Comment("InherentDamage", "Hard pass")
        });

        cList4.AddRange(new List<Comment>
        {
            new Comment("apricot0907", "What a scam"),
            new Comment("Leeroeun", "It's easy to get rich if you already have money"),
            new Comment("JackieCodes", "You shouldn't encourage people to gamble on the stock market"),
            new Comment("Shakalaka", "I took all my life savings and invested it after watching this. See you again when I'm rich!")
        });

        foreach (Video video in videos)
        {
            video.GetVideoInfo();
        }
    }
}