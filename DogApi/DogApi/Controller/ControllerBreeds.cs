using DogApi.Model;
using DogApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DogApi.Controller
{
    public class ControllerBreeds
    {
        /// <summary>
        /// Вывод пород
        /// </summary>
        /// <returns></returns>
        public static List<Breeds> GetBreeds()
        {
            using (HttpClient client = new HttpClient())
            {
                string query = $"{Manager.RootUrl}breeds/list/all";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<ResponseApi<List<Breeds>>>(content.Result);
                return answer.Message;
            }
        }
    }
}
