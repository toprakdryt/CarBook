﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BannerDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultCoverUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        } 

        public async Task<IViewComponentResult> InvokeAsync()
        {
        
            var client = _httpClientFactory.CreateClient();
            var reponseneMessage = await client.GetAsync("https://localhost:7212/api/Banners");
            if (reponseneMessage.IsSuccessStatusCode)
            {
                var jsonData = await reponseneMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
