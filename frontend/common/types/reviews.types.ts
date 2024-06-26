import type { BaseUser } from "./auth.types";
import type { Restaurant } from "./restaurants.types";

export type Review = {
    id: string;
    title: string;
    dateVisited: string;
    foodQualityRating: number;
    serviceQualityRating: number;
    ambianceRating: number;
    valueForMoneyRating: number;
    overallRating: number;
    comment: string;
    restaurant?: Restaurant;
    user?: BaseUser;
    dishNames: string[];
    createdAt: string;
};

export type CreateReviewDto = {
    title: string;
    dateVisited: Date;
    foodQualityRating: number;
    serviceQualityRating: number;
    ambianceRating: number;
    valueForMoneyRating: number;
    overallRating: number;
    comment: string;
    dishNames: string[];
}