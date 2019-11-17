using System.Linq;
using Homework4.Clients;
using Homework4.Models;

namespace Homework4.SecondOrmLibrary
{
    public class SecondOrmAdapter: IOrmAdapter
    {
        private ISecondOrm _orm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _orm = secondOrm;
        }

        public void AddUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            _orm.Context.Users.Add(userEntity);
            _orm.Context.UserInfos.Add(userInfoEntity);
        }

        public DbUserEntity GetUser(int userId)
        {
            return _orm.Context.Users.First(i => i.Id == userId);
        }

        public DbUserInfoEntity GetUserInfo(int infoId)
        {
            return _orm.Context.UserInfos.First(i => i.Id == infoId);
        }

        public void RemoveUser(int userId)
        {
            var user = _orm.Context.Users.First(user => user.Id == userId);
            _orm.Context.UserInfos.RemoveWhere(userInfo => userInfo.Id == user.InfoId);
            _orm.Context.Users.Remove(user);
        }
    }
}

