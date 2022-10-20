using Beersender.Domain;
using FluentAssertions;

namespace Beersender.tests;

public abstract class Beersender_test
{
    public Beersender_test()
    {
            
    }

    private object[] _events;
    protected void Given(params object[] events)
    {
        _events = events;
    }

    protected void When(object command)
    {
        var router = new Command_router(_ => _events, @event => _new_events.Add(@event));
        router.Handle_command(command);
    }

    private List<object> _new_events = new();

    protected void Then(params object[] expected_events)
    {
        _new_events.ToArray().Should().BeEquivalentTo(expected_events);
    }
}