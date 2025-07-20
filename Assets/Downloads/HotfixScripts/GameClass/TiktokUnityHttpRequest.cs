using Game.Common;
using JFramework;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok
{
    public class TiktokUnityHttpRequest : UnityHttpRequest
    {
        ISerializer serializer;
        IDeserializer deserializer;
        public TiktokUnityHttpRequest(ISerializer serializer, IDeserializer deserializer)
        {
            this.serializer = serializer;
            this.deserializer = deserializer;
        }


        public void SetToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                RemoveHeader("Authorization");
            }
            else
            {
                AddHeader("Authorization", $"Bearer {token}");
            }
        }

        public async Task<T> PostBodyAsync<T>(string url, T body, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            string json = null;
            if (body != null)
            {
                json = serializer.Serialize(body);
            }
            var result = await PostAsync(url, json, encoding);
            var response = encoding.GetString(result);
            T responseObject = deserializer.ToObject<T>(response);
            return responseObject;
        }


        public async Task<AccountDTO> RequestLogin(string deviceUid)
        {
            var url = $"https://localhost:7289/Account/FastLogin";
            var body = new AccountDTO
            {
                Uid = deviceUid
            };
            var response = await PostBodyAsync(url, body);
            if (response == null)
            {
                throw new System.Exception("Login failed, response is null");
            }
            return response;
        }

        public async Task<GameDTO> RequestEnterGame(AccountDTO accountDTO)
        {
            var url = $"https://localhost:7289/api/Game/EnterGame";
            SetToken(accountDTO.Token);
            var result = await PostAsync(url);
            var response = Encoding.UTF8.GetString(result);
            var responseObject = deserializer.ToObject<GameDTO>(response);
            return responseObject;

        }

        public async Task<FightDTO> RequestFight(FightDTO fightDTO)
        {
            var url = $"https://localhost:7289/api/Fight/Fight";
         
            var response = await PostBodyAsync(url, fightDTO);
            if (response == null)
            {
                throw new System.Exception("Login failed, response is null");
            }
            return response;
        }
    }
}