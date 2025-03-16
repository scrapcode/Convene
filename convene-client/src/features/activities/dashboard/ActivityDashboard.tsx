import { Grid2 } from "@mui/material";
import ActivityList from "./ActivityList";
import ActivityDetail from "../details/ActivityDetail";
import ActivityForm from "../form/ActivityForm";

type Props = {
  activities: Activity[]
  selectActivity: (id: string) => void
  cancelSelectActivity: () => void
  selectedActivity?: Activity
  editMode: boolean
  openForm: (id: string) => void
  closeForm: () => void
  submitForm: (activity: Activity) => void
  handleDelete: (id: string) => void
};

export default function ActivityDashboard({
  activities,
  selectActivity,
  cancelSelectActivity,
  selectedActivity,
  editMode,
  openForm,
  closeForm,
  submitForm,
  handleDelete
}: Props) {
  return (
    <Grid2 container spacing={3}>
      <Grid2 size={7}>
        <ActivityList activities={activities} selectActivity={selectActivity} deleteActivity={handleDelete} />
      </Grid2>
      <Grid2 size={5}>
        {selectedActivity && !editMode &&
          <ActivityDetail
            activity={selectedActivity} cancelSelectActivity={cancelSelectActivity} openForm={openForm}
          />
        }
        {editMode &&
        <ActivityForm closeForm={closeForm} activity={selectedActivity} submitForm={submitForm} />}
      </Grid2>
    </Grid2>
  );
}
