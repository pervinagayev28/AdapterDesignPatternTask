interface IWorker
{
    void startTowork();
}



class Worker1 : IWorker
{
    public void startTowork()
    {
        Console.WriteLine("worker 1 started to work");
    }
}


class Worker2 : IWorker
{
    public void startTowork()
    {
        Console.WriteLine("worker 1 started to work");
    }
}




// but then workers came from the Turkey and they dont know that startedToWork() what it means


class Işci
{
    public void işeBaşla()
    {
        Console.WriteLine("işə başladı");
    }
}


//the problem

class Program
{
    static void Main(string[] args)
    {
        List<IWorker> workers = new List<IWorker>();
        workers.Add(new Worker1());
        workers.Add(new Worker2());

        //we cant add Turkish's worker beacuse it doesnt implement from IWorker
        //workers.Add(new Işci());  wrong


        //we can implement it from Iworker but it doesnt use startToWork() to work because it has special method 


        //the solution,we can creat a  adapter to cennect it with Iworker


        workers.Add(new AdapterTurkishWorker());
        foreach (IWorker worker in workers)
            worker.startTowork();


    }
}



//the solution


class AdapterTurkishWorker : Işci, IWorker
{
    public void startTowork()
    {
        işeBaşla();
    }
}

