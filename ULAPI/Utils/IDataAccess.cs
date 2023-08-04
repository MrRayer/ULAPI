using ULAPI.Models;

namespace ULAPI.Utils
{
    public interface IDataAccess
    {
        void addUser(UserModel user);
        void removeUser(UserModel user);
        void updateUser(UserModel user, UserModel newUser);
        bool validateUser(UserModel user);
    }
}