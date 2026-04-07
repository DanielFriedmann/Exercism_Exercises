// TODO: define the 'AccountType' enum
public enum AccountType
{
    Guest,
    User,
    Moderator
}

// TODO: define the 'Permission' enum

[Flags]
public enum Permission
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = Read | Write | Delete
    
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest: return Permission.Read;
            case AccountType.User: return Permission.Write | Permission.Read;
            case AccountType.Moderator: return Permission.Delete | Permission.Read | Permission.Write;
            default: return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant) => current | grant;
   
    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;
   
    public static bool Check(Permission current, Permission check) => (current & check) == check;
    
}
