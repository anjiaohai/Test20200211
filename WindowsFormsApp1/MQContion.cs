using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MQContion
    {
        public IConnection Connection(String TempUrl,String TempUserName,String TempUserPassWord , ref String TempRes)
        {
            try
            {
                ConnectionFactory TempConFac = new ConnectionFactory();
                TempConFac.UserName = TempUserName;//某个vhost下的用户
                TempConFac.Password = TempUserPassWord;//MQ密码
                TempConFac.VirtualHost = "/";
                TempConFac.RequestedHeartbeat = 60;//心跳检测配置
                Uri uri = new Uri(TempUrl);
                TempConFac.Endpoint = new AmqpTcpEndpoint(uri);
                IConnection Tempconn = TempConFac.CreateConnection();
                TempRes = "OK";
                return Tempconn; 
            }
            catch (Exception TempE)
            {
                TempRes = TempE.Message;
                return null;
            }
          
        }

        /// <summary>
        /// Creator:SE24,Date:2020-2-5 14:54:45
        /// SE7 Date:2020-2-5 14:54:45
        ///SE2 Date 20200205 15：46
        /// SE7 Date:2020-2-5 16:18
        /// </summary>
        public void se24Test(){
            String Temp1 = "开始";
            String Temp2 = "开始";
            String Temp2 = "测试11";
        }
        
        /// <summary>
        /// Creator:SE24,Date:2020-2-6 17:14:57
        /// 创建测试方法1
        /// </summary>
        public void TestVoid1()
        {
            String TempSE24 = "11111";

            String TempEnd = "合并演示";
        }
        
       //2020-02-11  15:02 Se2 提交测试
    }
}
