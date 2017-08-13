using System;
using System.Threading.Tasks;
using DataModels;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace Managers
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly IRestaurantDataAccessor _restaurantDataAccessor;
        //private readonly IAddressDataAccessor _addressDataAccessor;
        //private readonly IDishIngredientDataAccessor _dishIngredientDataAccessor;

        //public RestaurantManager(IRestaurantDataAccessor restaurantDataAccessor, IAddressDataAccessor addressDataAccessor,
        //    IDishIngredientDataAccessor dishIngredientDataAccessor)
        //{
        //    _restaurantDataAccessor = restaurantDataAccessor;
        //    _addressDataAccessor = addressDataAccessor;
        //    _dishIngredientDataAccessor = dishIngredientDataAccessor;
        //}

        //public async Task AddDishIngredientArray(DishIngredientDM dishIngredientArray)
        //{
        //    await _dishIngredientDataAccessor.AddDishIngredientArray(dishIngredientArray);
        //}

        public async Task<List<DishDM>> GetRestaurant(int restaurantId)
        {
            //var restaurantDataModel = await _restaurantDataAccessor.GetRestaurant(restaurantId);
            //var addressDataModel = await _addressDataAccessor.GetAddress(restaurantId);
            //var addressVM = BuildAddressVM(addressDataModel);
            //var dishIngredient = await _dishIngredientDataAccessor.GetDishIngredient(1);
            var dishes = await _restaurantDataAccessor.GetAllDishes(1);

            return  dishes;
        }

        //private AddressVM BuildAddressVM(AddressDM dataModel)
        //{
        //    if (dataModel == null)
        //        return null;

        //    return new AddressVM
        //    {
        //        Id = dataModel.Id,
        //        RestaurantId = dataModel.RestaurantId,
        //        StreetName = dataModel.StreetName,
        //        CityName = dataModel.CityName,
        //        StateName = dataModel.StateName,
        //        StateAbbr = dataModel.StateAbbr,
        //        Zip = dataModel.Zip,
        //        Country = dataModel.Country,
        //        CountryAbbr = dataModel.CountryAbbr
        //    };
        //}

        //private RestaurantVM BuildRestaurantVM(RestaurantDM dataModel)
        //{
        //    if (dataModel == null)
        //        return null;

        //    return new RestaurantVM
        //    {
        //        Id = dataModel.Id,
        //        RestaurantName = dataModel.RestaurantName
        //    };
        //}
    }
}
