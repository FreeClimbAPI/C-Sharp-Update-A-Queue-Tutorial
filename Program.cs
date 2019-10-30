using com.freeclimb.api;
using com.freeclimb.api.queue;

namespace UpdateQueue
{
    class Program
    {
        public static string getFreeClimbAccountId()
        {
          return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
        }

        public static string getFreeClimbAccountToken()
        {
          return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
        }

        static void Main(string[] args)
        {

          string alias = "My_FC_Queue";
          int maxSize = 10;
          string queueId = System.Environment.GetEnvironmentVariable("QUEUE_ID");

          // Create FreeClimbClient object
          FreeClimbClient client = new FreeClimbClient(getFreeClimbAccountId(),
                                              getFreeClimbAccountToken());

          QueueOptions options = new QueueOptions();
          options.setAlias(alias);
          options.setMaxSize(maxSize);

          // Invoke get method to modify the queue
          Queue queue = client.getQueuesRequester.update(queueId, options);
        }
    }
}
