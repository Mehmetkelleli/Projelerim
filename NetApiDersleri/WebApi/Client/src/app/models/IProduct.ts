import { ICategory } from "./ICategory"

export interface IProduct {
  id: number
  name: string
  nameUrl: string
  description: string
  pictureUrl: string
  price: number
  stock: number
  categoryId: number
  category: ICategory
}
