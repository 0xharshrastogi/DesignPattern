import { Component } from "./Component";
import { IComponentMediator } from "./IComponentMediator";

export class TextBox extends Component {
    value: string | null = null;

    constructor(mediator: IComponentMediator) {
        super(mediator);
    }

    updateValue(value: string) {
        this.value = value;
        this.mediator.notify(this, "TYPE");
    }
}
