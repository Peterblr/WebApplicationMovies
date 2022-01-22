using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(); // получение всех объектов
        Task<T> GetByIdAsync(int id); // получение одного объекта по id
        //Task CreateAsync(T item); // создание объекта
        Task UpdateAsync(int id, T item); // обновление объекта
        Task DeleteAsync(int id); // удаление объекта по id
        //Task Save();  // сохранение изменений
        Task AddAsync(T item);
    }
}
