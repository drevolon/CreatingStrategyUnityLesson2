using System.Threading;
using System.Threading.Tasks;

public interface IAwaitable<T>
{
	IAwaiter<T> GetAwaiter();
    Task WithCancellation(CancellationToken token);
}