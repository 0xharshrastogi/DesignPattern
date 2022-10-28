import { Component } from "./Component";

export interface IComponentMediator {
    notify(sender: Component, event: string): void;
}
