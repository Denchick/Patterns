using Homework4.Models;

namespace Homework4.FirstOrmLibrary
{
    public class FirstOrmAdapter: IOrmAdapter
    {
        private IFirstOrm<DbUserEntity> _userEntites { get;set; }
        private IFirstOrm<DbUserInfoEntity> _userInfoEntites { get;set; }

        public FirstOrmAdapter(IFirstOrm<DbUserEntity> userEntites, IFirstOrm<DbUserInfoEntity> userInfoEntites)
        {
            _userEntites = userEntites;
            _userInfoEntites = userInfoEntites;
        }

        public DbUserEntity GetUser(int userId)
        {
            return _userEntites.Read(userId);
        }

        public DbUserInfoEntity GetUserInfo(int infoId)
        {
            return _userInfoEntites.Read(infoId);
        }

        public void AddUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            this._userEntites.Add(userEntity);
            this._userInfoEntites.Add(userInfoEntity);
        }

        public void RemoveUser(int userId)
        {
            var user = _userEntites.Read(userId);
            var userInfo = _userInfoEntites.Read(user.InfoId);

            _userEntites.Delete(user);
            _userInfoEntites.Delete(userInfo);
        }
    }
}
