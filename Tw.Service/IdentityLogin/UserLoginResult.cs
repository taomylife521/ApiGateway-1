namespace Tw.Service
{
    /// <summary>
    /// Represents the customer login result enumeration
    /// </summary>
    public enum UserLoginResult
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        Successful = 1,
        /// <summary>
        /// 用户不存在
        /// </summary>
        UserNotExist = 2,
        /// <summary>
        /// 密码错误
        /// </summary>
        WrongPassword = 3,
        /// <summary>
        /// 用户没有审核
        /// </summary>
        NotCheck = 4
    }
}