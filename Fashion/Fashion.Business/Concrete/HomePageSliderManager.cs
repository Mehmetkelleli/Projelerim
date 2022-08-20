using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Concrete
{
    public class HomePageSliderManager : IHomePageSliderService
    {
        private IHomePageSliderRepository _HomePageSlider;
        public HomePageSliderManager(IHomePageSliderRepository HomePageSlider)
        {
            _HomePageSlider = HomePageSlider;
        }
        public void Create(HomePageSlider T)
        {
            _HomePageSlider.Create(T);
        }

        public void Delete(HomePageSlider T)
        {
            _HomePageSlider.Delete(T);
        }

        public List<HomePageSlider> GetAll()
        {
            return _HomePageSlider.GetAll();
        }

        public HomePageSlider GetById(int id)
        {
            return _HomePageSlider.GetById(id);
        }

        public void Update(HomePageSlider T)
        {
            _HomePageSlider.Update(T);
        }
    }
}
