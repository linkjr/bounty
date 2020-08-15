using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Schedule
{
    public class MiniProgram
    {
        public HttpClient Client
        {
            get
            {
                var client = new HttpClient()
                {
                    BaseAddress = new Uri("https://api.q.qq.com/")
                };
                return client;
            }
        }

        public MiniProgram()
        {
        }

        public async Task<string> GetToken()
        {
            var url = "/api/getToken?grant_type=client_credential&appid=1110140900&secret=SDA3GouCAWKCeYsu";
            var response = await Client.SendAsync(new HttpRequestMessage(HttpMethod.Get, url));
            var result = await response.Content.ReadAsStringAsync();
            return result;
            //W6EVJGTMCiduWFZ0AjfPAGKvvN097_EMwL3wCreY9ixo1MhDBC-YUesv9U5QudOceXnx
        }

        public async Task<string> Code2Session()
        {
            var code = "5be23ba4ba7a19ad84f16f710044d885";
            var url = $"/sns/jscode2session?appid=1110140900&secret=SDA3GouCAWKCeYsu&js_code={code}&grant_type=authorization_code";
            var response = await Client.SendAsync(new HttpRequestMessage(HttpMethod.Get, url));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> SendTemplateMessage()
        {
            var url = "/api/json/template/send?access_token=S0Zkm7g67EX2v2zqbmiRGZEcy_mtpc4XJQkKMyeYcxUDrbe3XtW1CM79_4JbNfE6FBmf";
            var paras = new
            {
                touser = "6ea79e291b6870647a35d445c29b49b0",
                template_id = "8b970d3cdc84de82182a3a0f9403749a",
                form_id = "ae800751c01040f0a3dafb20da3a61e2",
                data = new
                {
                    keyword1 = new { value = "339208499" },
                    keyword2 = new { value = "2019年5月05日 12:30" },
                    keyword3 = new { value = "腾讯大厦" },
                    keyword4 = new { value = "深圳市南山区高新科技园中区一路" },
                    keyword5 = new { value = "深圳市南山区高新科技园中区一路" }
                }
            };
            var message = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(JsonConvert.SerializeObject(paras), Encoding.UTF8, "application/json"),
            };
            var response = await Client.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
