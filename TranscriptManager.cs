using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class TranscriptManager : ITranscriptService
    {
        ITranscriptDal _transcriptDal;

        public TranscriptManager(ITranscriptDal transcriptDal)
        {
            _transcriptDal = transcriptDal;
        }

        Transcript IGenericService<Transcript>.GetByID(int id)
        {
            return _transcriptDal.GetById(id);
        }

        void IGenericService<Transcript>.TAdd(Transcript t)
        {
            _transcriptDal.Insert(t);
        }

        void IGenericService<Transcript>.TDelete(Transcript t)
        {
            _transcriptDal.Delete(t);
        }

        List<Transcript> IGenericService<Transcript>.TGetList()
        {
            return _transcriptDal.GetList();
        }

        void IGenericService<Transcript>.TUpdate(Transcript t)
        {
            _transcriptDal.Update(t);
        }
    }
}
