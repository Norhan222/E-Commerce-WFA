using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Commerce.Application.Services
{
    public class CartService : ICartService
    {
        ICartRepo _CartRepo;

        public CartService (ICartRepo catrepo)
        {
            _CartRepo = catrepo;
        }

        public void AddToCart(CartDto cartDto)
        {
            //if (Quantity <= 0)
            //    throw new ArgumentException("Quantity must be greater than 0");
            var Cart = _CartRepo.GetCartByUserId(cartDto.UserId);
            if (Cart == null)
            {
                Cart = new Cart
                {
                    UserId = cartDto.UserId,
                };
                _CartRepo.CreateCart(Cart);
                _CartRepo.Save();
            }
            var cartitem = Cart.CartItems.FirstOrDefault(c=>c.Product.Id==cartDto.ProductId);
            if (cartitem != null)
            {
                cartitem.Quantity += 1;
            }
            else
            {
                Cart.CartItems.Add(new CartItem
                {
                    ProductId = cartDto.ProductId,
                    Quantity = 1
                });
            }
            _CartRepo.UpdateCart(Cart);
            _CartRepo.Save();

        }

        public void ClearCart(int UserId)
        {
            var cart = _CartRepo.GetCartByUserId(UserId);
            if ( cart == null ) 
                return;
            cart.CartItems.Clear();
            _CartRepo.UpdateCart(cart);
            _CartRepo.Save();

        }

        public Cart GetCartById(int UserId)
        {
            var cart= _CartRepo.GetCartByUserId(UserId);
            return cart;
        }

        public void RemoveFromCart(int UserId, int ProductId)
        {
            var cart = _CartRepo.GetCartByUserId(UserId);
            if ( cart == null ) return;

            var item = cart.CartItems.FirstOrDefault(c => c.ProductId == ProductId);
            if ( item != null )
            {
                cart.CartItems.Remove(item);
                _CartRepo.UpdateCart(cart);
                _CartRepo.Save();
            }
        }

        public void Save()
        {
            _CartRepo.Save();
        }

     
    }
}
