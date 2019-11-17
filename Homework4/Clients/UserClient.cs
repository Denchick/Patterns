using Homework4.Models;

namespace Homework4.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = _ormAdapter.GetUser(userId);
            var userInfo = _ormAdapter.GetUserInfo(user.InfoId);

            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.AddUser(user, userInfo);
        }

        public void Remove(int userId)
        {
            _ormAdapter.RemoveUser(userId);
        }
    }
}
