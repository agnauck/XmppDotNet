using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace XmppDotNet
{
    // https://github.com/dotnet/reactive/issues/459
    public static class RxExtensions
    {
        public static IDisposable SubscribeAsync<T>(this IObservable<T> source, Func<Task> onNextAsync) =>
            source
                .Select(number => Observable.FromAsync(onNextAsync))
                .Concat()
                .Subscribe();

        public static IDisposable SubscribeAsyncConcurrent<T>(this IObservable<T> source, Func<Task> onNextAsync) =>
            source
                .Select(number => Observable.FromAsync(onNextAsync))
                .Merge()
                .Subscribe();

        public static IDisposable SubscribeAsyncConcurrent<T>(this IObservable<T> source, Func<Task> onNextAsync, int maxConcurrent) =>
            source
                .Select(number => Observable.FromAsync(onNextAsync))
                .Merge(maxConcurrent)
                .Subscribe();

        public static IDisposable SubscribeAsync<T>(this IObservable<T> source, Func<T, Task> onNextAsync) =>
            source
                .Select(number => Observable.FromAsync(() => onNextAsync(number)))
                .Concat()
                .Subscribe();

        public static IDisposable SubscribeAsyncConcurrent<T>(this IObservable<T> source, Func<T, Task> onNextAsync) =>
            source
                .Select(number => Observable.FromAsync(() => onNextAsync(number)))
                .Merge()
                .Subscribe();

        public static IDisposable SubscribeAsyncConcurrent<T>(this IObservable<T> source, Func<T, Task> onNextAsync, int maxConcurrent) =>
            source
                .Select(number => Observable.FromAsync(() => onNextAsync(number)))
                .Merge(maxConcurrent)
                .Subscribe();
    }

}
