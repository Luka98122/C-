public class Account
{
    public string Username;
    public string Email;
    public string Bio;
    public List<Account> Followers;
    public List<Account> Following;

    public Account(string username, string email, string bio)
    {
        Username = username;
        Email = email;
        Bio = bio;
        Followers = new List<Account>();
        Following = new List<Account>();
    }

    public void PrintFollowers()
    {
        Console.WriteLine($"{Username}'s followers:");
        if (Followers.Count == 0)
        {
            Console.WriteLine("No followers.");
        }
        else
        {
            for (int i = 0;i<Followers.Count;i++)
            {
                Console.WriteLine($"- {Followers[i].Username}");
            }
        }
    }

    public void Follow(Account accountToFollow)
    {
        if (!Following.Contains(accountToFollow))
        {
            Following.Add(accountToFollow);
            accountToFollow.Followers.Add(this);
        }
    }
    public void PrintFollowing()
    {
        Console.WriteLine($"{Username} is following:");
        if (Following.Count == 0)
        {
            Console.WriteLine("Nobody");
        }
        else
        {
            foreach (var following in Following)
            {
                Console.WriteLine($"- {following.Username}");
            }
        }
    }
}

public class Main2()
{
    public static void Main()
    {
        var admin = new Account("admin", "admin@example.com", "Administrator");

        var accounts = new List<Account>();
        for (int i = 1; i < 20; i++)
        {
            var account = new Account($"user{i}", $"user{i}@example.com", $"Bio of user{i}");
            accounts.Add(account);
        }

        foreach (var account in accounts)
        {
            account.Follow(admin);
        }
        admin.Follow(accounts[5]);
        admin.PrintFollowers();
        admin.PrintFollowing();
            
    }
}