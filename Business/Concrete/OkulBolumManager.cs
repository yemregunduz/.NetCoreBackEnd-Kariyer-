using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Dtos;

namespace Business.Concrete
{
    public class OkulBolumManager : IOkulBolumService
    {
        IOkulBolumDal _okulBolumDal;
        public OkulBolumManager(IOkulBolumDal okulBolumDal)
        {
            _okulBolumDal = okulBolumDal;
        }
        public IResult Add(OkulBolum okulBolum)
        {
            _okulBolumDal.Add(okulBolum);
            return new SuccessResult(Messages.OkulEklendi);
        }

        public IDataResult<OkulBolum> AddReturnOkulBolumId(OkulBolum okulBolum)
        {
            return new SuccessDataResult<OkulBolum>(_okulBolumDal.AddReturnOkulBolumId(okulBolum), Messages.OkullarListelendi);
        }

        public IResult Delete(OkulBolum okulBolum)
        {
            _okulBolumDal.Delete(okulBolum);
            return new SuccessResult(Messages.OkulSilindi);
        }

        public IDataResult<List<OkulBolum>> GetAll()
        {
            return new SuccessDataResult<List<OkulBolum>>(_okulBolumDal.GetAll(), Messages.OkullarListelendi);
        }

        public IDataResult<List<OkulBolumDto>> GetAllOkulBolumlerByOkulId(int okulId)
        {
            return new SuccessDataResult<List<OkulBolumDto>>(_okulBolumDal.GetAllOkulBolumByOkulId(okulId), Messages.OkulDetayGetirildi);
        }

        public IDataResult<List<OkulBolum>> GetAllOkulByBolumId(int bolumId)
        {
            return new SuccessDataResult<List<OkulBolum>>(_okulBolumDal.GetAll(o => o.BolumId == bolumId));
        }

        public IResult Update(OkulBolum okulBolum)
        {
            _okulBolumDal.Update(okulBolum);
            return new SuccessResult(Messages.OkulGüncellendi);
        }
    }
}
