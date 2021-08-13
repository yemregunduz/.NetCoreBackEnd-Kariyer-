using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYorumService
    {
        IResult Add(Yorum yorum);
        IResult Delete(Yorum yorum);
        IResult Update(Yorum yorum);
        IDataResult<List<Yorum>> GetAll();
        IDataResult<List<YorumDetayDto>> GetAllYorumDetayDtoByGonderiId(int gonderiId);
    }
}
