import type { IComponentMediator } from "./IComponentMediator";

export abstract class Component {
    protected readonly mediator: IComponentMediator;

    protected constructor(componentMediator: IComponentMediator) {
        this.mediator = componentMediator;
    }
}
