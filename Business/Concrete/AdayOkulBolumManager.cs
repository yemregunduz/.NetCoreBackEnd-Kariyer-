using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdayOkulBolumManager : IAdayOkulBolumService
    {
        IAdayOkulBolumDal _adayOkulBolumDal;
        public AdayOkulBolumManager(IAdayOkulBolumDal adayOkulBolumDal)
        {
            _adayOkulBolumDal = adayOkulBolumDal;
        }
        public IResult Add(AdayOkulBolum adayOkulBolum)
        {
            _adayOkulBolumDal.Add(adayOkulBolum);
            return new SuccessResult(Messages.OkulEklendi);
        }

        public IResult Delete(AdayOkulBolum adayOkulBolum)
        {
            _adayOkulBolumDal.Delete(adayOkulBolum);
            return new SuccessResult(Messages.OkulSilindi);
        }

        public IDataResult<List<AdayOkulBolum>> GetAll()
        {
            return new SuccessDataResult<List<AdayOkulBolum>>(_adayOkulBolumDal.GetAll(), Messages.OkullarListelendi);
        }

        public IDataResult<List<AdayOkulBolumDto>> GetAllAdayOkulBolumDto(int adayId)
        {
            return new SuccessDataResult<List<AdayOkulBolumDto>>(_adayOkulBolumDal.GetAllAdayOkulBolumDtoByAdayId(adayId), Messages.OkullarListelendi);
        }

        public IDataResult<List<AdayOkulBolum>> GetAllByAdayId(int adayId)
        {
            return new SuccessDataResult<List<AdayOkulBolum>>(_adayOkulBolumDal.GetAll(aob => aob.AdayId == adayId), Messages.OkullarListelendi);
        }

        public IResult Update(AdayOkulBolum adayOkulBolum)
        {
            _adayOkulBolumDal.Update(adayOkulBolum);
            return new SuccessResult(Messages.OkulGüncellendi);
        }
    }
}
