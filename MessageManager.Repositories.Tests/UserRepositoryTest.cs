﻿/**
* author:xishuai
* address:https://www.github.com/yuezhongxin/MessageManager
**/

using MessageManager.Domain.DomainModel;
using MessageManager.Domain.Repositories;
using MessageManager.Repositories.EntityFramework;
using Xunit;

namespace MessageManager.Repositories.Tests
{
    public class UserRepositoryTest
    {
        [Fact]
        public void AddUserRepository()
        {
            IUserRepository userRepository = new UserRepository(new EntityFrameworkRepositoryContext());
            User user1 = new User("小菜");
            User user2 = new User("大神");
            userRepository.Add(user1);
            userRepository.Add(user2);
            userRepository.Context.Commit();
        }

        [Fact]
        public void GetUserRepository()
        {
            IUserRepository userRepository = new UserRepository(new EntityFrameworkRepositoryContext());
            User user = userRepository.GetUserByName("大神");
        }
    }
}
