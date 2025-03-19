import { DateArg, format } from "date-fns";

export function formatDate(date: DateArg<Date>) {
  return format(date, "MMM dd, yyyy h:mm a");
}
