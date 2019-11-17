using Homework4.Models;

namespace Homework4
{
    public interface IOrmAdapter // ITarget
    {
        DbUserEntity GetUser(int userId);
        DbUserInfoEntity GetUserInfo(int infoId);
        void AddUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity);
        void RemoveUser(int userId);
    }
}
