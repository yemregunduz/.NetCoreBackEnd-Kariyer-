using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YetenekManager : IYetenekService
    {
        IYetenekDal _yetenekDal;
        public YetenekManager(IYetenekDal yetenekDal)
        {
            _yetenekDal = yetenekDal;
        }
        public IResult Add(Yetenek yetenek)
        {
            _yetenekDal.Add(yetenek);
            return new SuccessResult(Messages.YetenekEklendi);
        }

        public IResult Delete(Yetenek yetenek)
        {
            _yetenekDal.Delete(yetenek);
            return new SuccessResult(Messages.YetenekSilindi);
        }

        public IDataResult<List<Yetenek>> GetAll()
        {
            return new SuccessDataResult<List<Yetenek>>(_yetenekDal.GetAll(), Messages.YeteneklerListelendi);
        }

        public IDataResult<List<YetenekDetayDto>> GetAllYetenekDetayDtoBySearchFilter(string filterText)
        {
            return new SuccessDataResult<List<YetenekDetayDto>>(_yetenekDal.GetAllYetenekDetayDto(y => y.YetenekAdi.Contains(filterText)||y.YetenekTipi.Contains(filterText)));
        }

        public IDataResult<Yetenek> GetByYetenekId(int yetenekTipId)
        {
            return new SuccessDataResult<Yetenek>(_yetenekDal.Get(y=>y.YetenekTipId==yetenekTipId), Messages.YeteneklerListelendi);
        }

        public IResult Update(Yetenek yetenek)
        {
            _yetenekDal.Update(yetenek);
            return new SuccessResult(Messages.YetenekGuncellendi);
        }
    }
}
