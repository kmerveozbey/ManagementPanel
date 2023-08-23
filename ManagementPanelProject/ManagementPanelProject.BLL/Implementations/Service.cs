using AutoMapper;
using ManagementPanelProject.DAL;
using ManagementPanelProject.Entity.ResultModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.BLL.Implementations
{
    public class Service<TViewModel, TModel, Id> : IService<TViewModel, Id>
          where TViewModel : class, new()
          where TModel : class, new()
    {
        private readonly IRepository<TModel, Id> _repo;
        private readonly IMapper _mapper;
        private readonly string _includeEntities;

        public Service(IMapper mapper, IRepository<TModel, Id> repo,
            string includeEntities = null)
        {
            _mapper = mapper;
            _repo = repo;
            _includeEntities = includeEntities;
        }

        public IDataResult<TViewModel> Add(TViewModel model)
        {
            try
            {
                TModel tmodel = _mapper.Map<TViewModel, TModel>(model);
                bool result = _repo.Add(tmodel);
                TViewModel dataModel = _mapper.Map<TModel, TViewModel>(tmodel);

                return result ?
                    new DataResult<TViewModel>(true, StringLibrary.AddSuccess, dataModel)
                    : new DataResult<TViewModel>(false, StringLibrary.AddError, dataModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IResult Delete(TViewModel model)
        {
            try
            {
                TModel mdl = _mapper.Map<TViewModel, TModel>(model);
                bool deleteResult = _repo.Delete(mdl);
                var mdl1 = _mapper.Map<TModel, TViewModel>(mdl);
                return deleteResult ? new DataResult<TViewModel>(true, StringLibrary.DeleteSuccess, mdl1)
                : new DataResult<TViewModel>(false, StringLibrary.DeleteError, mdl1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<ICollection<TViewModel>> GetAll(Expression<Func<TViewModel, bool>> filter = null)
        {
            try
            {
                var fltr = _mapper.Map<Expression<Func<TViewModel, bool>>,
                    Expression<Func<TModel, bool>>>(filter);
                var data = _repo.GetAll(fltr, includeEntities: _includeEntities);

                ICollection<TViewModel> dataList =
                    _mapper.Map<IQueryable<TModel>, ICollection<TViewModel>>(data);

                return new DataResult<ICollection<TViewModel>>(true, $"{dataList.Count} " + StringLibrary.Quantity + " " + StringLibrary.SendRecord, dataList);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TViewModel> GetByConditions(Expression<Func<TViewModel, bool>> filter = null)
        {
            try
            {
                var fltr = _mapper.Map<Expression<Func<TViewModel, bool>>, Expression<Func<TModel, bool>>>(filter);
                var data = _repo.GetByConditions(fltr, _includeEntities);
                if (data == null)
                {
                    return new DataResult<TViewModel>(false, StringLibrary.NoRecord, null);
                }

                var mdl = _mapper.Map<TModel, TViewModel>(data);
                return new DataResult<TViewModel>(true, StringLibrary.FoundRecord, mdl);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TViewModel> GetById(Id id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception(StringLibrary.NullError);
                }
                var data = _repo.GetById(id);
                if (data == null)
                {
                    throw new Exception(StringLibrary.NoRecord);
                }
                var mdl = _mapper.Map<TModel, TViewModel>(data.Result);
                return new DataResult<TViewModel>(true, $"{id} " + StringLibrary.WithID + " " + StringLibrary.NoRecord, mdl);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IResult Update(TViewModel model)
        {
            try
            {
                TModel mdl = _mapper.Map<TViewModel, TModel>(model);
                var updateResult = _repo.Update(mdl);
                var mdl1 = _mapper.Map<TModel, TViewModel>(mdl);
                return updateResult ?
                    new DataResult<TViewModel>(true, StringLibrary.UpdateSuccess, mdl1)
                    : new DataResult<TViewModel>(false, StringLibrary.UpdateError, mdl1);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Login(TViewModel model)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}