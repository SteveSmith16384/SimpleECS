using System.Collections.Generic;

public abstract class AbstractSystem {

    protected BasicEcs ecs;

    public AbstractSystem(BasicEcs _ecs) {
        this.ecs = _ecs;

        this.ecs.AddSystem(this);

    }

    // Override if required to run against all entities
    public virtual void Process(List<AbstractEntity> entities) {
		foreach (AbstractEntity entity in entities) {
			this.ProcessEntity(entity);
		}
	}
	
	
	public virtual void ProcessEntity(AbstractEntity entity) {
		// Override if required to run against a single entity.
	}


}
