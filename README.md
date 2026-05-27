In Ostranauts 0.15 (and previous versions as long as I've known), when you leave the OKLG area for a long-distance trip, you get absolutely sandblasted with micrometeoroids.
When I took a look at why, I'm fairly sure it's a bug.

Basically, when the game decides it's time for an event, it rolls a number. Then, for each event type in sequence, it:
- Checks if the roll is < the chance of this event happening and the event is elligible to happen.
- If so, it runs the event. If not, it doesn't.
- It subtracts the chance of this event happening from the roll.
- If the event happened, it stops processing and resets the event timer. If not, it continues to the next event in sequence.

Now, that sounds on the surface like it's a pretty good way of handling it. The probabilities don't have to be whole numbers, they don't have to add up to 100%, it's all pretty flexible.
So, why does that make the chance of a micrometeoroid impacts suddenly become enormous? Because it subtracts the chance of the event happening whether or not it happens.
This effectively makes every event which isn't elligible to happen add its chance to the next event, and it stacks.

While I don't know for sure whether or not this is by design, it really feels to me like a bug. So I fixed it.

This mod makes it so that if an event was rolled, it stops processing and resets the timer, whether or not it was elligible to happen.
It's done in a way that should be pretty low-impact and forwards-compatible with future versions, too.
