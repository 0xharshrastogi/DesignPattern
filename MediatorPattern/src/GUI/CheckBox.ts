import { Component } from "./Component";
import { IComponentMediator } from "./IComponentMediator";

export class CheckBox extends Component {
    isChecked: boolean = false;

    constructor(mediator: IComponentMediator) {
        super(mediator);
    }

    check() {
        this.isChecked = !this.isChecked;
        this.mediator.notify(this, "CHECK");
    }
}
