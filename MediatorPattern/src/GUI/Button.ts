import { Component } from "./Component";
import { IComponentMediator } from "./IComponentMediator";

export class Button extends Component {
    constructor(mediator: IComponentMediator) {
        super(mediator);
    }

    click() {
        console.log("Button Clicked");
        this.mediator.notify(this, "CLICK");
    }
}
