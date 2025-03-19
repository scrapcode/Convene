import { Group } from "@mui/icons-material";
import { Box, Button, Paper, Typography } from "@mui/material";
import { Link } from "react-router";

export default function Homepage() {
  return (
    <Paper
      sx={{
        color: "white",
        display: "flex",
        flexDirection: "column",
        gap: 6,
        alignItems: "center",
        alignContents: "center",
        justifyContent: "center",
        height: "100vh",
        backgroundImage:
          "linear-gradient(135deg,rgb(43, 90, 104) 0%,rgb(33, 174, 167) 69%,rgb(14, 212, 120) 89%)",
      }}
    >
      <Box
        sx={{
          display: "flex",
          alignItems: "center",
          alignCotnent: "center",
          color: "white",
          gap: 3,
        }}
      >
        <Group sx={{height: 110, width: 110}} />
        <Typography variant="h1">
          Covene
        </Typography>
      </Box>
      <Typography variant="h2">
        Welcome to Convene
      </Typography>
      <Button component={Link} to='/activities' size="large" variant="contained" sx={{height: 80, borderRadius: 4, fontSize: '1.5rem'}}>
        Show me the events!
      </Button>
    </Paper>
  );
}
