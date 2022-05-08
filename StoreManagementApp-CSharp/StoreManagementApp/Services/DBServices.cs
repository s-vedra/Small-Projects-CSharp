using Models;

namespace Services
{
    public static class DBServices<T> where T : BaseEntity
    {
        public delegate void PrintMultpleHandler(List<T> entities);
        public delegate void EventHandleGroupingEmployees(Dictionary<T, int> grouped);

        public static int ReturnId(List<T> entities)
        {
            int id = entities.Count + 1;

            foreach (T entity in entities)
            {
                if (entity.Id == id)
                {
                    id++;
                }
            }
            return id;
        }
        public static T ReturnEntity(List<T> entities)
        {
            while (true)
            {
                try
                {
                    PrintMultiple(entities, (entities) => entities.ForEach(entity => Console.WriteLine($"{entity.Id} {entity.GetInfo()}")));
                    int answer = HelperMethods.CheckString().Parsing();
                    T entity = entities.SingleOrDefault(entity => entity.Id == answer);
                    if (entity == null)
                    {
                        throw new Exception("Not found, try again");
                    }
                    return entity;
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    continue;
                }
            }

        }

        public static T AssignEntity(int id, List<T> entities)
        {
            return entities.Single(entity => entity.Id == id);
        }

        public static void AddEntity(List<T> entities, T entity)
        {
            entities.Add(entity);
        }

        public static void RemoveEntity(List<T> entities, T entity)
        {
            entities.Remove(entity);
        }

        public static void PrintSingular(string entity)
        {
            Console.WriteLine(entity);
        }
        public static void PrintMultiple(List<T> entities, PrintMultpleHandler print)
        {
            print(entities);
        }
    }
}
