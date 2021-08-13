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
    public class YorumManager : IYorumService
    {
        IYorumDal _yorumDal;
        public YorumManager(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }
        public IResult Add(Yorum yorum)
        {
            _yorumDal.Add(yorum);
            return new SuccessResult(Messages.YorumEklendi);
        }

        public IResult Delete(Yorum yorum)
        {
            _yorumDal.Delete(yorum);
            return new SuccessResult(Messages.YorumSilindi);
        }

        public IDataResult<List<Yorum>> GetAll()
        {
            return new SuccessDataResult<List<Yorum>>(_yorumDal.GetAll(), Messages.TumYorumlarListelendi);
        }

        public IDataResult<List<YorumDetayDto>> GetAllYorumDetayDtoByGonderiId(int gonderiId)
        {
            return new SuccessDataResult<List<YorumDetayDto>>(_yorumDal.GetAllYorumDetayDto(y => y.GonderiId == gonderiId), Messages.GonderininYorumlariListelendi);
        }

        public IResult Update(Yorum yorum)
        {
            _yorumDal.Update(yorum);
            return new SuccessResult(Messages.YorumGuncellendi);
        }
    }
}
