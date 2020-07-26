import { Feature } from "./feature";
import { Item } from "./item";

export class ItemFeature {
    id: number;
    itemId: number;
    featureId: number;
    value: string;
    feature: Feature = new Feature();
    item: Item = new Item();
}