import { Guid } from "guid-typescript";
import { IModel } from "../_interfaces/imodel";

export class  AssetModel implements IModel {
  id: Guid;
  fileName: string;
  fileExtention: string;
  originalFileName: string;
  mimeType: string;
}
