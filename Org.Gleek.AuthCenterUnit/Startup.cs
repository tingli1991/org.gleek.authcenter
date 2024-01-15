using Com.GleekFramework.AutofacSdk;
using Com.GleekFramework.ConfigSdk;
using Com.GleekFramework.DapperSdk;
using Com.GleekFramework.HttpSdk;
using Com.GleekFramework.NacosSdk;
using Com.GleekFramework.QueueSdk;
using Org.Gleek.AuthCenter.Models;

namespace Org.Gleek.AuthCenterUnit
{
    /// <summary>
    /// Ӧ�ó���
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// ��̬���캯��
        /// </summary>
        static Startup()
        {
            CreateDefaultHostBuilder()
                .Build()
                .SubscribeQueue();
        }

        /// <summary>
        /// ����Ĭ�ϵ�����
        /// </summary>
        /// <returns></returns>
        private static IHostBuilder CreateDefaultHostBuilder() =>
            Host.CreateDefaultBuilder()
            .UseAutofac()
            .UseConfig()
            .UseNacosConf()
            .UseHttpClient()
            .UseConfigAttribute()
            .UseDapper(DatabaseConstant.AuthCenterHosts, DatabaseConstant.AuthCenterOnlyHosts)
            .UseDapperColumnMap("Org.Gleek.AuthCenter.Entitys", "Org.Gleek.AuthCenter.Models");
    }
}