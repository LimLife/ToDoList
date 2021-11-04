using System.Runtime.Serialization.Formatters.Binary;

public interface ISave
{
    void Save(ITask task);
    ITask LoadTask(string filePath);
    void Remove(string filePath);
    BinaryFormatter GetFormatter();

}
