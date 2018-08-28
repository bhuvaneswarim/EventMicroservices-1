﻿using Microsoft.AspNetCore.Mvc;
using Polly.CircuitBreaker;
using WebMvc.Models;
using WebMvc.Models.CartModels;
using WebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.ViewComponents
{
    public class CartList:ViewComponent
    {
        private readonly ICartService _cartSvc;

        public CartList(ICartService cartSvc) => _cartSvc = cartSvc;
        public async Task<IViewComponentResult> InvokeAsync(ApplicationUser user)
        {


            var vm = new Models.CartModels.Cart();
            try
            {
                vm = await _cartSvc.GetCart(user);

                
                return View(vm);
            }
            catch (BrokenCircuitException)
            {
                // Catch error when CartApi is in open circuit mode
                ViewBag.IsCartBasketInoperative = true;
                TempData["CartBasketInoperativeMsg"] = "CartBasket Service is inoperative, please try later on. (Business Msg Due to Circuit-Breaker)";
            }

            return View(vm);
        }




    }
}
