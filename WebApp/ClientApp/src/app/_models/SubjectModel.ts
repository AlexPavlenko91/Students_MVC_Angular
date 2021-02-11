import { Guid } from "guid-typescript";
import { IModel } from "../_interfaces/imodel";

export class  SubjectModel implements IModel {
  id: Guid;
  name: string;
}
