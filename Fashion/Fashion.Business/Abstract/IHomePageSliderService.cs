using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface IHomePageSliderService
    {
        void Create(HomePageSlider T);
        void Update(HomePageSlider T);
        void Delete(HomePageSlider T);
        List<HomePageSlider> GetAll();
        HomePageSlider GetById(int id);
    }
}
