using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
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
        IGenericRepo<Product, int> _productRepo;
        ICartRepo _CartRepo;

        public CartService (ICartRepo catrepo, IGenericRepo<Product, int> prorepo)
        {
            _CartRepo = catrepo;
            _productRepo = prorepo;
        }

        public void AddToCart(int UseerId, int ProductId, int Quantity)
        {
            if (Quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0");

            var Product = _productRepo.GetById(ProductId);

            if (Product == null)
                throw new ArgumentException("Product not found");

            var Cart = _CartRepo.GetCartByUserId(UseerId);
            if ( Cart == null)
            {
                Cart = new Cart
                {
                   UserId = UseerId,
                   CartItems = new List<CartItem>()
                };
                _CartRepo.CreateCart(Cart);
                _CartRepo.Save();
            }

            //هنا هيروح يشوف البرودكت متضاف اصلا ولا لا لو متضاف يزود العدد لو لا مش متضاف يضفه 
            var existingItem = Cart.CartItems.FirstOrDefault(ci=>ci.ProductId== ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += Quantity;
            }
            else
            {
                Cart.CartItems.Add(new CartItem
                {
                    ProductId = ProductId,
                    Quantity = Quantity
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
            return _CartRepo.GetCartByUserId(UserId);
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
    }
}
