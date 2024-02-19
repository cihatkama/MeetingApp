
namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo() { Id = 1, Name = "Cihat KAMA", Email = "cihatkama@cktech.com", Phone = "+90111111111", WillAttend = true });
        _users.Add(new UserInfo() { Id = 2, Name = "Yüksel KAMA", Email = "cihatkama@cktech.com", Phone = "+903333333", WillAttend = true });
        _users.Add(new UserInfo() { Id = 3, Name = "Emre KAMA", Email = "emrekama@cktech.com", Phone = "+9022222222", WillAttend = false });
        _users.Add(new UserInfo() { Id = 4, Name = "Esra YALÇIN", Email = "esrayalcin@cktech.com", Phone = "+904444444", WillAttend = false });
        _users.Add(new UserInfo() { Id = 5, Name = "Fatoş KAMA", Email = "fatoskama@cktech.com", Phone = "+9055555555", WillAttend = true });
    }

    public static List<UserInfo> Users { get => _users; }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }
}