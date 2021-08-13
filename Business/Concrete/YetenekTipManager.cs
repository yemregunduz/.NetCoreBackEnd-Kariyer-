using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YetenekTipManager : IYetenekTipService
    {
        IYetenekTipDal _yetenekTipDal;
        public YetenekTipManager(IYetenekTipDal yetenekTipDal)
        {
            _yetenekTipDal = yetenekTipDal;
        }
        public IResult Add(YetenekTip yetenekTip)
        {
            _yetenekTipDal.Add(yetenekTip);
            return new SuccessResult(Messages.YetenekTipiEklendi);
        }

        public IResult Delete(YetenekTip yetenekTip)
        {
            _yetenekTipDal.Delete(yetenekTip);
            return new SuccessResult(Messages.YetenekTipiSilindi);
        }

        public IDataResult<List<YetenekTip>> GetAll()
        {
            return new SuccessDataResult<List<YetenekTip>>(_yetenekTipDal.GetAll(), Messages.YetenekTipleriListelendi);
        }

        public IDataResult<YetenekTip> GetByYetenekTipId(int id)
        {
            return new SuccessDataResult<YetenekTip>(_yetenekTipDal.Get(y => y.Id == id));
        }

        public IResult Update(YetenekTip yetenekTip)
        {
            _yetenekTipDal.Update(yetenekTip);
            return new SuccessResult(Messages.YetenekTipiGuncellendi);
        }
    }
}
