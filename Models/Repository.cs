
namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo() { Name = "Cihat KAMA", Email = "cihatkama@cktech.com", Phone = "+90111111111", WillAttend = true });
        _users.Add(new UserInfo() { Name = "Yüksel KAMA", Email = "cihatkama@cktech.com", Phone = "+903333333", WillAttend = true });
        _users.Add(new UserInfo() { Name = "Emre KAMA", Email = "emrekama@cktech.com", Phone = "+9022222222", WillAttend = false });
        _users.Add(new UserInfo() { Name = "Esra YALÇIN", Email = "esrayalcin@cktech.com", Phone = "+904444444", WillAttend = false });
        _users.Add(new UserInfo() { Name = "Fatoş KAMA", Email = "fatoskama@cktech.com", Phone = "+9055555555", WillAttend = true });
    }

    public static List<UserInfo> Users { get => _users; }

    public static void CreateUser(UserInfo user)
    {
        _users.Add(user);
    }
}