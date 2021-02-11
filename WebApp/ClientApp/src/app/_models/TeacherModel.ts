import { Guid } from "guid-typescript";
import { IModel } from "../_interfaces/imodel";

export class TeacherModel implements IModel {
  id: Guid;
  firstName: string;
  lastName: string;
}
